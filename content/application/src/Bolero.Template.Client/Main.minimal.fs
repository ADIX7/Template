module Bolero.Template.Client.Main

open Elmish
open Bolero
open Bolero.Html
//#if (hotreload_actual)
open Bolero.Templating.Client
//#endif

type Model = unit

let initModel = ()

type Message = unit

let update message model =
    match message with
    | _ -> model

let view model dispatch =
    empty

type MyApp() =
    inherit ProgramComponent<Model, Message>()

    override this.Program =
        Program.mkSimple (fun _ -> initModel) update view
//#if (hotreload_actual)
#if DEBUG
        |> Program.withHotReloading
#endif
