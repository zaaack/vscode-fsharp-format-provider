#r "/Users/z/.nuget/packages/Paket.Core/5.96.2/lib/netstandard1.6/Paket.Core.dll" 

#r "/Users/z/.nuget/packages/System.IO.FileSystem.Primitives/4.3.0/lib/netstandard1.3/System.IO.FileSystem.Primitives.dll" 

#r "/Users/z/.nuget/packages/System.IO.FileSystem/4.3.0/lib/net46/System.IO.FileSystem.dll"
open Paket


let file = Paket.DependenciesFile.FindLocalfile "FantomasCLI"

printfn "%A" file
