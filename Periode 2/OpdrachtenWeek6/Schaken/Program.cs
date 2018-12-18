using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schaken
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            ChessPiece[,] chessboard = new ChessPiece[8, 8];
            InitChessBoard(chessboard);
            DisplayChessBoard(chessboard);
            PlayChess(chessboard);
            
        }
        void InitChessBoard(ChessPiece[,] chessboard)
        {
            for (int r = 0; r < chessboard.GetLength(0); r++)
            {
                for (int k = 0; k < chessboard.GetLength(1); k++)
                {
                    chessboard[r, k] = null;
                }
            }
            PutChessPieces(chessboard);
        }
        void PutChessPieces(ChessPiece[,] chessboard)
        {
            ChessPieceType[] order = { ChessPieceType.Rook, ChessPieceType.Knight, ChessPieceType.Bishop
                                     , ChessPieceType.King, ChessPieceType.Queen, ChessPieceType.Bishop
                                     , ChessPieceType.Knight, ChessPieceType.Rook};
            for (int r = 0; r < chessboard.GetLength(0); r++)
            {
                for (int k = 0; k < chessboard.GetLength(1); k++)
                {
                    chessboard[r, k] = new ChessPiece();
                    switch (r)
                    {
                        case 0:
                            chessboard[r, k].color = ChessPieceColor.White;
                            chessboard[r, k].type = order[k];
                            break;
                        case 1:
                            chessboard[r, k].color = ChessPieceColor.White;
                            chessboard[r, k].type = ChessPieceType.Pawn;
                            break;
                        case 6:
                            chessboard[r, k].color = ChessPieceColor.Black;
                            chessboard[r, k].type = ChessPieceType.Pawn;
                            break;
                        case 7:
                            chessboard[r, k].color = ChessPieceColor.Black;
                            chessboard[r, k].type = order[k];
                            break;
                        default:
                            chessboard[r, k] = null;
                            break;
                    }
                    
                     
                }
            }
        }

        Position ReadPosition(string question)
        {
            Position p = new Position();

            Console.Write(question);
            string userPos = Console.ReadLine();

            p.column = userPos[0] - 'A';
            p.row = int.Parse(userPos[1].ToString()) - 1;

            return p;
        }

        void DoMove(ChessPiece[,] chessboard, Position from, Position to)
        {
            chessboard[to.row, to.column] = chessboard[from.row, from.column];
            chessboard[from.row, from.column] = null;
        }
        void CheckMove(ChessPiece[,] chessboard, Position from, Position to)
        {
            if(chessboard[from.row,from.column] != null 
               && chessboard[to.row,to.column].color != chessboard[from.row, from.column].color)
            {
                DoMove(chessboard, from, to);
            }

        }
        bool validMove(ChessPiece chessPiece, Position from, Position to)
        {
            int horDiff;
            int vertDiff;
            horDiff = Math.Abs(from.column - to.column);
            vertDiff = Math.Abs(from.row - to.row);





            return false;
        }

        void PlayChess(ChessPiece[,] chessboard)
        {
            while (true)
            {
                Position before = ReadPosition("Enter 'from position' (e.g. A2): ");
                Position after = ReadPosition("Enter 'to position' (e.g. A3): ");
                // CheckMove
                // DoMove
                DoMove(chessboard, before, after);
                DisplayChessBoard(chessboard);
            }
        }



        void DisplayChessPiece(ChessPiece chessPiece)
        {
            if (chessPiece != null)
            {
                switch (chessPiece.color)
                {
                    case ChessPieceColor.White:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case ChessPieceColor.Black:
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                }
                switch (chessPiece.type)
                {
                    case ChessPieceType.Pawn:
                        Console.Write(" p ");
                        break;
                    case ChessPieceType.Rook:
                        Console.Write(" r ");
                        break;
                    case ChessPieceType.Knight:
                        Console.Write(" k ");
                        break;
                    case ChessPieceType.Bishop:
                        Console.Write(" b ");
                        break;
                    case ChessPieceType.Queen:
                        Console.Write(" Q ");
                        break;
                    case ChessPieceType.King:
                        Console.Write(" K ");
                        break;
                }
            }
            else
            {
                Console.Write("   ");
            }
        }

        void DisplayChessBoard(ChessPiece[,] chessboard)
        {
            Console.WriteLine("   A  B  C  D  E  F  G  H");
            for (int r = 0; r < chessboard.GetLength(1); r++)
            {
                Console.Write($"{r+1} ");
                for (int k = 0; k < chessboard.GetLength(1); k++)
                {
                    if ((r+k) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }

                    DisplayChessPiece(chessboard[r, k]);
                    if (k+1 == chessboard.GetLength(1))
                    {
                        k = 0;
                        Console.WriteLine();
                        break;
                    }
                    
                }

                Console.ResetColor();
            }
        }
    }
}
