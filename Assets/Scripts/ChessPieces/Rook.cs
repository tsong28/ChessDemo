using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : ChessPiece
{
    public override List<Vector2> GetPossibleMoves(ref ChessPiece[,] board, int tileCountX, int tileCountY)
    {
        List<Vector2> possibleMoves = new List<Vector2>();

        //right
        for(int i = currentX+1; i < tileCountX; i++)
        {
            if(board[i, currentY] == null)
            {
                possibleMoves.Add(new Vector2(i, currentY));
            }
            else
            {
                if (board[i, currentY].team == team)
                {
                    break;
                }
                possibleMoves.Add(new Vector2(i, currentY));
                break;
            }
        }

        //left
        for (int i = currentX - 1; i >= 0; i--)
        {
            if (board[i, currentY] == null)
            {
                possibleMoves.Add(new Vector2(i, currentY));
            }
            else
            {
                if (board[i, currentY].team == team)
                {
                    break;
                }
                possibleMoves.Add(new Vector2(i, currentY));
                break;
            }
        }

        //up
        for (int i = currentY + 1; i < tileCountY; i++)
        {
            if (board[currentX, i] == null)
            {
                possibleMoves.Add(new Vector2(currentX, i));
            }
            else
            {
                if(board[currentX, i].team == team)
                {
                    break;
                }
                possibleMoves.Add(new Vector2(currentX, i));
                break;
            }
        }

        //down
        for (int i = currentY - 1; i >= 0; i--)
        {
            if (board[currentX, i] == null)
            {
                possibleMoves.Add(new Vector2(currentX, i));
            }
            else
            {
                if (board[currentX, i].team == team)
                {
                    break;
                }
                possibleMoves.Add(new Vector2(currentX, i));
                break;
            }
        }



        return possibleMoves;
    }
}
