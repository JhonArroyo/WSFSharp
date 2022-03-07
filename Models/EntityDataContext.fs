namespace WSFsharp.Models

open Microsoft.EntityFrameworkCore
open System.Linq
open WSFsharp.Models.Tables

type EntityDataContext(options: DbContextOptions<EntityDataContext>) =
    inherits DbContext(options)
    
    [<DefaultValue>]
    val mutuable people : DbSet<Person>
    member public this.People with get() = this.people
                            and set value = this.people <- value
