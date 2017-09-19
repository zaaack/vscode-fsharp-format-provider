module FormatProvider.FFI

open Fable.Core
open Fable.Core.JsInterop
open Fable.Import

[<Global("process")>]
let Process: Node.Process.Process = jsNative
let ChildProcess: Node.ChildProcess.IExports = importDefault "child_process"

let c = ChildProcess.spawn "ls"

printfn "%s" (Process.cwd ())

printfn "aaa"