namespace AllControls.Gtk

open System
open Xamarin.Forms
open Xamarin.Forms.Platform.GTK

module Main =
    [<EntryPoint>]
    let Main(args) =
        Gtk.Application.Init()
        Forms.Init()

        let app = new AllControls.App()
        let window = new FormsWindow()
        window.LoadApplication(app)
        window.SetApplicationTitle("AllControls")
        window.Show();

        Gtk.Application.Run()
        0
