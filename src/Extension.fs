module FormatProvider.Extension

open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Fable.Import.Browser
open Fable.Import.JS
open Fable.Import.vscode
open FormatProvider.FFI
open FormatProvider.Fantomascli

printfn "%s" (Process.cwd())
printfn "%A" (ChildProcess.execSync("ls"))

// type FSharpFormatProvider() =
//     interface vscode.DocumentFormattingEditProvider
//         member this.provideDocumentFormattingEdits (document, options, token) =
//             let x = async { return 99 }
//             async {
//                 let! x = x
//                 let y = 99
//                 return TextEdit
//             } |> Async.StartAsPromise


let active (context : ExtensionContext) = 
    ()
