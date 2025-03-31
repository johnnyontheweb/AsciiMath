Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Xml.Xsl
Imports AsciiMath

Module Program
    Sub Main(args As String())
        Console.WriteLine("AsciiMath converter")
conv:   Console.WriteLine("Input formula:")
        Dim form = Console.ReadLine()
        Dim out As String = Parser.ToMathMl(form)
        Console.WriteLine("Converted MathML:")
        Console.WriteLine(out)
        Console.WriteLine("Converted OMML:")
        Console.WriteLine(ConvertMathMLtoOMML(out))
        ' loop
        Console.WriteLine("")
        Console.WriteLine("Convert another one? (y/n)")
        Dim key = Console.ReadKey(True).Key
        If key = ConsoleKey.Y Then GoTo conv
        Exit Sub
    End Sub

    ' conversione in OMML
    Public Function ConvertMathMLtoOMML(MMLtext As String) As String
        Dim xslTransform As New XslCompiledTransform()

        Try
            ' Il file MML2OMML.xsl si trova in %ProgramFiles%\Microsoft Office\Office16\root\
            xslTransform.Load("MML2OMML.xsl")
        Catch ex As Exception
            Throw New FileNotFoundException("XSLT file not found or invalid.", ex)
        End Try

        Using reader As XmlReader = XmlReader.Create(New StringReader(MMLtext))
            Using ms As New MemoryStream()
                Dim settings As XmlWriterSettings = xslTransform.OutputSettings.Clone()

                ' Configura lo scrittore XML per omettere la dichiarazione XML.
                settings.ConformanceLevel = ConformanceLevel.Fragment
                settings.OmitXmlDeclaration = True

                Dim xw As XmlWriter = XmlWriter.Create(ms, settings)

                ' Trasforma il nostro OfficeMathML in MathML
                Try
                    xslTransform.Transform(reader, xw)
                Catch ex As Exception
                    Throw New InvalidOperationException("Transformation failed.", ex)
                End Try

                ms.Seek(0, SeekOrigin.Begin)

                Dim sr As New StreamReader(ms, Encoding.UTF8)
                Return sr.ReadToEnd()
            End Using
        End Using
    End Function
End Module