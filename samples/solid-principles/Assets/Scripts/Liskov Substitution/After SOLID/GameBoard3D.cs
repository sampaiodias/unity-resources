namespace SampaioDias.SolidPrinciples.LiskovSubstitution.After
{

    using UnityEngine;

    public class GameBoard3D : MonoBehaviour
    {
        GameTile[,,] Tiles3d = new GameTile[100, 100, 100];

        public void SetTile(int x, int y, int z, GameTile tile)
        {
            Tiles3d[x, y, z] = tile;
        }

        //Other methods
    }
}
