﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Fractal")>]
[<assembly: AssemblyProductAttribute("Fractal")>]
[<assembly: AssemblyVersionAttribute("0.0.2")>]
[<assembly: AssemblyFileVersionAttribute("0.0.2")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.2"
