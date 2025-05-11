module Fyxion.Route

open System.Collections.Generic

let routes = Dictionary<string, unit -> string>()

let get path handler =
  routes.Add(path, handler)

let handle path =
  match routes.TryGetValue(path) with
  | true, h -> h()
  | _ -> "404 Not Found"