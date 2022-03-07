namespace WSFsharp.Models
open System
open System.ComponentModel.DataAnnotations

module Tables
    [<CLIMutable>]
    type Person = {
        Id : int
        [<Required>] 
        Age : int
        [<Required>]
        Url : string
    }

    