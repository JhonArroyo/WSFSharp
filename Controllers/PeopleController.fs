namespace WSFSharp.Controllers

open Microsoft.AspNetCore.Mvc
open System.Collections.Generic

//module PeopleController
type Person = 
    {name : string; 
     age : int; 
     url : string;}

[<ApiController>]
[<Route("[controller]")>]
type PeopleController() = 
    inherit ControllerBase()

    let people = {
        name= "Jhon";
        age= 24;
        url= "https://localhost/";}

    [<HttpGet>]
    member _.Get() =
        //"WEB API SERVICE WITH F#"
        base.Ok(people)
        


