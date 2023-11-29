// For more information see https://aka.ms/fsharp-console-apps
// TypeScript Example
// Define the discriminated union genre
// Discriminated Union for Genre without 'kind'
type Genre =
    | Horror
    | Drama
    | Thriller
    | Comedy
    | Fantasy
    | Sport

type Dir = {
    Name: string
    Movies: int
}

type Movie = {
    Name: string
    RunLength: int
    Genre: Genre
    Director: Dir
    IMDBRating: float
}

let hardpart runLength =
    let hours = runLength / 60
    let minutes = runLength % 60
    sprintf "%dh %02dmin" hours minutes


let coda = {
    Name = "CODA"
    RunLength = 111
    Genre = Drama
    Director = { Name = "Sian Heder"; Movies = 9 }
    IMDBRating = 8.1
}

let belfast = {
    Name = "Belfast"
    RunLength = 98
    Genre = Comedy
    Director = { Name = "Kenneth Branagh"; Movies = 23 }
    IMDBRating = 7.3
}

let dontLookUp = {
    Name = "Don't Look Up"
    RunLength = 138
    Genre = Comedy
    Director = { Name = "Adam McKay"; Movies = 27 }
    IMDBRating = 7.2
}

let driveMyCar = {
    Name = "Drive My Car"
    RunLength = 179
    Genre = Drama
    Director = { Name = "Ryusuke Hamaguchi"; Movies = 16 }
    IMDBRating = 7.6
}

let dune = {
    Name = "Dune"
    RunLength = 155
    Genre = Fantasy
    Director = { Name = "Denis Villeneuve"; Movies = 24 }
    IMDBRating = 8.1
}

let kingRichard = {
    Name = "King Richard"
    RunLength = 144
    Genre = Sport
    Director = { Name = "Reinaldo Marcus Green"; Movies = 15 }
    IMDBRating = 7.5
}

let licoricePizza = {
    Name = "Licorice Pizza"
    RunLength = 133
    Genre = Comedy
    Director = { Name = "Paul Thomas Anderson"; Movies = 49 }
    IMDBRating = 7.4
}

let nightmareAlley = {
    Name = "Nightmare Alley"
    RunLength = 150
    Genre = Thriller
    Director = { Name = "Guillermo del Toro"; Movies = 22 }
    IMDBRating = 7.1
}


let movies = [coda; belfast; dontLookUp; driveMyCar; dune; kingRichard; licoricePizza; nightmareAlley]

let run = List.map (fun movie -> hardpart movie.RunLength) movies

let oscarWinners = List.filter (fun movie -> movie.IMDBRating > 7.4) movies

printfn "And the oscar goes to"
oscarWinners |> List.iter (fun movie -> 
    printfn "%s" movie.Name
    printfn "rating: %.2f" movie.IMDBRating
    printfn ""
)

printfn "Time:"
movies |> List.iter (fun movie -> 
    printfn "%s  %s" movie.Name (hardpart movie.RunLength)
)
