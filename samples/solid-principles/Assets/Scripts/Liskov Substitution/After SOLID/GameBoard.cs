namespace SampaioDias.SolidPrinciples.LiskovSubstitution.After
{

    using UnityEngine;

    public class GameBoard : MonoBehaviour
    {
        GameTile[,] Tiles = new GameTile[100, 100];

        public void SetTile(int x, int y, GameTile tile)
        {
            Tiles[x, y] = tile;
        }

        //Other methods
    }
}
