module bbn
let validator(test: int, testInput: string) = 
    //define valid opening/closing brackets & helper map vice versa lookup
    let openBrackets = ['('; '{'; '['; '<']
    let closeBrackets = [')'; '}'; ']'; '>']
    let bracketMap = Map.ofList (List.zip openBrackets closeBrackets) 
    // Input formatting
    let input = [System.IO.File.ReadAllLines("input").[0]; testInput] 
    let charlist = List.ofSeq input[test]
    
    //recursive function to validate brackets
    let rec validate (charlist2: char list) (index: int) (stack: char list) = 
        match charlist2 with
        | head :: tail when List.contains head openBrackets -> validate tail (index + 1) ((Map.find head bracketMap) :: stack)
        | head :: tail when List.contains head closeBrackets -> 
            match stack with
            | [] -> index // case empty stack, not enough opening brackets
            | stackHead :: stackTail when stackHead = head -> validate tail (index + 1) stackTail
            | _ -> index // any other case means mismatched brackets
        | _ :: tail -> validate tail (index + 1) stack // not a valid bracket, skip
        | [] when stack.IsEmpty -> -1 // valid string
        | [] -> index-1// case no more chars, return previous index
    //initial call            
    validate charlist 0 []

let result = validator(0, "")
printfn "%A" result
// Test cases
(*
let testcases = ["(>"; "[<<>]"; "({}<>])"; "(<{()}{}{}><<>{[]}>[<<>><{}>{}>[]<>][]{}[])"; "({}<>)"; "[[[[[[[]]]]]]({<>})]"; "{}<()[]>"]
let expected = [1; 4; 5; 30; -1; -1; -1]
let results = testcases |> List.map (fun x -> validator(1, x)) = expected
printfn "%A" results
*)