﻿module Drawing

let getIcon plyr =
    match plyr with
   
    | 1 -> "X"
    | 2 -> "0"

let rec consColorWrite =
    fun (msg : string) ->
        let head = msg.Chars 0
        let newMsg = msg.Substring(1)
        match head with
        | 'X' ->
            System.Console.ForegroundColor<-System.ConsoleColor.Red
            System.Console.Write(head);
        | '0' ->
            System.Console.ForegroundColor<-System.ConsoleColor.Blue
            System.Console.Write(head);
        | '[' | ']' | '-' | '|' | '\\' | '/' | ',' ->
            System.Console.ForegroundColor<-System.ConsoleColor.DarkGray
            System.Console.Write(head);
        | a ->
            System.Console.ForegroundColor<-System.ConsoleColor.White
            System.Console.Write(head);
        match newMsg with
        | "" -> System.Console.WriteLine() // End line
        | _ -> consColorWrite newMsg

let whatBoardDraws =
    fun item ->
        match item with
        | 0 -> ' '
        | 1 -> 'X'
        | 2 -> '0'

let drawBoard =
    fun (board: int list) ->
        let lin00 =         "\t  \t1,2,3    4    5,6,7"
        let lin01 = sprintf "\t[A]\t%c--------%c--------%c" (whatBoardDraws (board.Item 0)) (whatBoardDraws (board.Item 1)) (whatBoardDraws (board.Item 2))
        let lin02 =         "\t   \t|\       |       /|"
        let lin03 = sprintf "\t[B]\t| %c------%c------%c |" (whatBoardDraws (board.Item 8)) (whatBoardDraws (board.Item 9)) (whatBoardDraws (board.Item 10))
        let lin04 =         "\t   \t| |\     |     /| |"
        let lin05 = sprintf "\t[C]\t| | %c----%c----%c | |" (whatBoardDraws (board.Item 16)) (whatBoardDraws (board.Item 17)) (whatBoardDraws (board.Item 18))
        let lin06 =         "\t   \t| | |         | | |"
        let lin07 = sprintf "\t[D]\t%c-%c-%c         %c-%c-%c" (whatBoardDraws (board.Item 7)) (whatBoardDraws (board.Item 15)) (whatBoardDraws (board.Item 23)) (whatBoardDraws (board.Item 19)) (whatBoardDraws (board.Item 11)) (whatBoardDraws (board.Item 3))
        let lin08 =         "\t   \t| | |         | | |"
        let lin09 = sprintf "\t[E]\t| | %c----%c----%c | |" (whatBoardDraws (board.Item 22)) (whatBoardDraws (board.Item 21)) (whatBoardDraws (board.Item 20))
        let lin10 =         "\t   \t| |/     |     \| |"
        let lin11 = sprintf "\t[F]\t| %c------%c------%c |" (whatBoardDraws (board.Item 14)) (whatBoardDraws (board.Item 13)) (whatBoardDraws (board.Item 12))
        let lin12 =         "\t   \t|/       |       \|"
        let lin13 = sprintf "\t[G]\t%c--------%c--------%c" (whatBoardDraws (board.Item 6)) (whatBoardDraws (board.Item 5)) (whatBoardDraws (board.Item 4))
        let boundString = "\n\n" + lin00 + "\n\n" + lin01 + "\n" + lin02 + "\n" + lin03 + "\n" 
                                                  + lin04 + "\n" + lin05 + "\n" + lin06 + "\n"
                                                  + lin07 + "\n" + lin08 + "\n" + lin09 + "\n" 
                                                  + lin10 + "\n" + lin11 + "\n" + lin12 + "\n" 
                                                  + lin13 + "\n";
        consColorWrite boundString


let writeError (msg : string) =
    System.Console.ForegroundColor<-System.ConsoleColor.Magenta
    System.Console.WriteLine(msg)
    System.Threading.Thread.Sleep(1750)