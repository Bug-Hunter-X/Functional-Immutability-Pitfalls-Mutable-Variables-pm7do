let mutable x = 10

let addOne x = 
    x <- x + 1 //Use <- operator to modify the mutable variable
    x

let y = addOne x

printfn "%d" y //Prints 11
printfn "%d" x //Prints 11