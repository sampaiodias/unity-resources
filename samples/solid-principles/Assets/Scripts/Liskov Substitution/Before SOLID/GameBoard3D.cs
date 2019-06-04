namespace SampaioDias.SolidPrinciples.LiskovSubstitution.Before
{
    //Tiles and SetTile(int x, int y, GameTile tile) still exists here (inherited from GameBoard),
    //so we have two "Tiles" variables and two "SetTile" methods.
    public class GameBoard3D : GameBoard
    {
        GameTile[,,] Tiles3d = new GameTile[100, 100, 100];

        public void SetTile(int x, int y, int z, GameTile tile)
        {
            Tiles3d[x, y, z] = tile;
        }
    }
}
