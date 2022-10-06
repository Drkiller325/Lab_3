class Program{
    static void Main(string[] args){
        int ch;
        while(true){
            Console.WriteLine("Choose the ChessPiece you want to Check");
            Console.WriteLine("1.King");
            Console.WriteLine("2.Queen");
            Console.WriteLine("3.Knight");
            Console.WriteLine("4.Rook");
            Console.WriteLine("5.Bishop");
            Console.WriteLine("6.Pawn");
            Console.WriteLine("7.Exit");
            Console.WriteLine("enter your CHOICE");
            ch = Convert.ToInt32(Console.ReadLine());
            if(ch == 7){
                break;
            }
            switch(ch){
                case 1:
                    ChessPiece king = new King();
                    king.readers("E1",1);
                    king.move();
                    Console.WriteLine("The position: " + king.position + " Count: " + king.count + " Color: " + king.PieceColor + "\n");
                    break;

                case 2:
                    ChessPiece queen = new Queen();
                    queen.readers("D1",1);
                    queen.move();
                    Console.WriteLine("The position: " + queen.position + " Count: " + queen.count + " Color: " +queen.PieceColor + "\n");
                    break;

                case 3:
                    ChessPiece knight = new Knight();
                    knight.readers("B1,G1",2);
                    knight.move();
                    Console.WriteLine("The position: " + knight.position + " Count: " + knight.count + " Color: " + knight.PieceColor + "\n");
                    break;

                    case 4:
                        ChessPiece rook = new Rook();
                        rook.readers("A1,H1",2);
                        rook.move();
                        Console.WriteLine("The position: " + rook.position + " Count: " + rook.count + " Color: " + rook.PieceColor + "\n");
                        break;

                    case 5:
                        ChessPiece bishop = new Bishop();
                        bishop.readers("C1,F1",2);
                        bishop.move();
                        Console.WriteLine("The position: " + bishop.position + " Count: " + bishop.count + " Color: " +bishop.PieceColor + "\n");
                        break;
                    case 6:
                        ChessPiece pawn = new Pawn();
                        pawn.readers("A1-H1",8);
                        pawn.move();
                        Console.WriteLine("The position: " + pawn.position + " Count: " + pawn.count + " Color: " + pawn.PieceColor + "\n");
                        break;
                    default:
                        Console.WriteLine("Try Again");
                        break;
            }
        }
}

}
