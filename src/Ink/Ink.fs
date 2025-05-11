namespace Ink

open System.Collections.Generic

[<AbstractClass>]
type Ink<'T when 'T : not struct>() =

  static let store = Dictionary<int, 'T>()
  static let mutable nextId = 1

  member _.save (item: 'T) =
    let id = 
      match box item with
      | :? { Id: int} as record when record.id <> 0 -> record.Id
      | _ ->
        let id = nextId
        nextId <- nextId + 1
        id
    store.[id] <- item

  member _.find(id: int) =
    match store.TryGetValue(id) with
    | true,  v -> Some v
    | _ -> None

  member _.all () =
    store.Values :> seq<'T>
    