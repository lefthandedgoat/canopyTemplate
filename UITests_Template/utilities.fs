module utilities

open canopy.parallell.functions

let writeTab x selector input =
    write selector input x
    press tab x
    |> ignore