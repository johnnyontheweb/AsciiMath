﻿namespace AsciiMathParser;

// Keeping the original names for simplicity
// ReSharper disable InconsistentNaming
public enum Symbol
{
    // Operation symbols
    plus,
    minus,
    cdot,
    ast,
    star,
    slash,
    backslash,
    setminus,
    times,
    ltimes,
    rtimes,
    bowtie,
    div,
    circ,
    oplus,
    otimes,
    odot,
    sum,
    prod,
    wedge,
    bigwedge,
    vee,
    bigvee,
    cap,
    bigcap,
    cup,
    bigcup,

//Relation symbols
    eq,
    ne,
    assign,
    lt,
    mlt,
    gt,
    mgt,
    le,
    ge,
    prec,
    succ,
    preceq,
    succeq,
    @in,
    notin,
    subset,
    supset,
    subseteq,
    supseteq,
    equiv,
    sim,
    cong,
    approx,
    propto,

// Logical symbols
    and,
    or,
    not,
    implies,
    @if,
    iff,
    forall,
    exists,
    bot,
    top,
    vdash,
    models,

// Grouping brackets
    lparen,
    rparen,
    lbracket,
    rbracket,
    lbrace,
    rbrace,
    vbar,
    // lrparen,
    langle,
    rangle,
    parallel, // can't work out how this is generated

// Miscellaneous symbols
    integral,
    dx,
    dy,
    dz,
    dt,
    contourintegral,
    partial,
    nabla,
    pm,
    mp,
    emptyset,
    infty,
    aleph,
    ellipsis,
    therefore,
    because,
    angle,
    triangle,
    prime,
    tilde,
    nbsp,
    frown,
    quad,
    qquad,
    cdots,
    vdots,
    ddots,
    diamond,
    square,
    lfloor,
    rfloor,
    lceiling,
    rceiling,
    dstruck_captial_c,
    dstruck_captial_n,
    dstruck_captial_q,
    dstruck_captial_r,
    dstruck_captial_z,
    f,
    g,


// Standard functions
    lim,
    Lim,
    min,
    max,
    sin,
    Sin,
    cos,
    Cos,
    tan,
    Tan,
    sinh,
    Sinh,
    cosh,
    Cosh,
    tanh,
    Tanh,
    cot,
    Cot,
    sec,
    Sec,
    csc,
    Csc,
    arcsin,
    arccos,
    arctan,
    coth,
    sech,
    csch,
    exp,
    abs,
    norm,
    floor,
    ceil,
    log,
    Log,
    ln,
    Ln,
    det,
    dim,
    ker,
    mod,
    gcd,
    lcm,
    lub,
    glb,

// Arrows
    uparrow,
    downarrow,
    rightarrow,
    to,
    rightarrowtail,
    twoheadrightarrow,
    twoheadrightarrowtail,
    mapsto,
    leftarrow,
    leftrightarrow,
    Rightarrow,
    Leftarrow,
    Leftrightarrow,

// Other
    sqrt,
    root,
    frac,
    stackrel,
    overset,
    underset,
    color,
    sub,
    sup,
    hat,
    overline,
    vec,
    dot,
    ddot,
    overarc,
    underline,
    underbrace,
    overbrace,
    cancel,
    bold,
    double_struck,
    italic,
    bold_italic,
    script,
    bold_script,
    monospace,
    fraktur,
    bold_fraktur,
    sans_serif,
    bold_sans_serif,
    sans_serif_italic,
    sans_serif_bold_italic,
    roman,

// Greek letters
    alpha,
    Alpha,
    beta,
    Beta,
    gamma,
    Gamma,
    delta,
    Delta,
    epsilon,
    Epsilon,
    varepsilon,
    zeta,
    Zeta,
    eta,
    Eta,
    theta,
    Theta,
    vartheta,
    iota,
    Iota,
    kappa,
    Kappa,
    lambda,
    Lambda,
    mu,
    Mu,
    nu,
    Nu,
    xi,
    Xi,
    omicron,
    Omicron,
    pi,
    Pi,
    rho,
    Rho,
    sigma,
    Sigma,
    tau,
    Tau,
    upsilon,
    Upsilon,
    phi,
    Phi,
    varphi,
    chi,
    Chi,
    psi,
    Psi,
    omega,
    Omega,
}