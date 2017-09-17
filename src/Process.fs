module FormatProvider.Process

open Fable.Core
open Fable.Core.JsInterop
open Fable.Import

[<Global("process")>]
let Process: Node.Process.Process = jsNative

printfn "%s" (Process.cwd ())

printfn "aaa"