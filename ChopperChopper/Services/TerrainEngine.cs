using ChopperChopper.Interfaces;
using ChopperChopper.Models;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ChopperChopper.Services
{
    public class TerrainEngine
    {
        public TerrainEngine(Control playGround, IGameEnvironment gameEnvironment)
        {
            PlayGround = playGround;
            GameEnvironment = gameEnvironment;
            TopObstacles = new LinkedList<Obstacle>();
            BottomObstacles = new LinkedList<Obstacle>();

            ObstacleRandomizer = new Randomizer(MinObstacleHeight, MaxObstacleHeight, ObstacleHeightChangeRate, 100);
        }

        private LinkedList<Obstacle> TopObstacles { get; set; }
        private LinkedList<Obstacle> BottomObstacles { get; set; }
        public List<Obstacle> DeadlyObstacles { get; set; }
        public Control PlayGround { get; set; }
        public IGameEnvironment GameEnvironment { get; }
        public int GameSpeed { get; set; } = 5;
        public Randomizer ObstacleRandomizer { get; set; }
        public int ObstacleWidth { get; set; } = 50;
        public int MinObstacleHeight { get; set; } = 25;
        public int MaxObstacleHeight { get; set; } = 175;
        public int ObstacleEqualHeights { get; set; } = 100;
        public int ObstacleHeightChangeRate { get; set; } = 25;
        public Color ObstacleColor { get; set; } = Color.Gray;

        public void SetupTerrain()
        {
            ObstacleRandomizer.CurrentPoint = ObstacleRandomizer.CurrentInvertedPoint = ObstacleEqualHeights;

            DestroyExistingObstacles(TopObstacles);
            DestroyExistingObstacles(BottomObstacles);

            GenerateAllObstacles(TopObstacles, 0);
            GenerateAllObstacles(BottomObstacles, PlayGround.Height - MinObstacleHeight);

            ReadyFinalObstacles(TopObstacles, false);
            ReadyFinalObstacles(BottomObstacles, true);

            SetDeadlyObstacles();
        }

        public void DestroyExistingObstacles(LinkedList<Obstacle> obstacles)
        {
            foreach (var obstacle in obstacles)
            {
                PlayGround.Controls.Remove(obstacle);
            }
            obstacles.Clear();
        }

        private void SetDeadlyObstacles()
        {
            DeadlyObstacles = new List<Obstacle> {
                TopObstacles.First.Value,
                TopObstacles.First.Next.Next.Value,
                TopObstacles.First.Next.Next.Value,
                BottomObstacles.First.Value,
                BottomObstacles.First.Next.Value,
                BottomObstacles.First.Next.Next.Value,
            };
        }

        public void RunEngine()
        {
            var TopEnumerator = TopObstacles.GetEnumerator();
            var BottomEnumerator = BottomObstacles.GetEnumerator();

            while (TopEnumerator.MoveNext() && BottomEnumerator.MoveNext())
            {
                MoveObstacle(TopEnumerator.Current);
                MoveObstacle(BottomEnumerator.Current);
            }

            TerrainCrossedUpdate();
        }

        private void MoveObstacle(Obstacle obstacle)
        {
            obstacle.Location = new Point(obstacle.Location.X - GameSpeed, obstacle.Location.Y);
        }

        private void TerrainCrossedUpdate()
        {
            var firstTopObstacle = TopObstacles.First.Value;
            var firstBottomObstacle = BottomObstacles.First.Value;

            if (firstTopObstacle.Location.X + ObstacleWidth < 0)
            {
                ObstacleRandomizer.Update();

                SendFirstObstacleToLast(TopObstacles);
                SendFirstObstacleToLast(BottomObstacles);
                firstTopObstacle.Height = ObstacleRandomizer.CurrentPoint;
                firstBottomObstacle.Height = ObstacleRandomizer.CurrentInvertedPoint;
                AdjustBottomObstacleLocationY(firstBottomObstacle);

                SetDeadlyObstacles();
                GameEnvironment.IncrementScore(1);
            }
        }

        private void SendFirstObstacleToLast(LinkedList<Obstacle> obstacles)
        {
            Obstacle firstObstacle = obstacles.First.Value;
            firstObstacle.Location = new Point(obstacles.Last.Value.Location.X + ObstacleWidth, firstObstacle.Location.Y);
            obstacles.AddLast(firstObstacle);
            obstacles.RemoveFirst();
        }

        private void GenerateAllObstacles(LinkedList<Obstacle> listToFill, int locationY)
        {
            Obstacle obstacle;
            do
            {
                obstacle = new Obstacle
                {
                    Height = MinObstacleHeight,
                    Width = ObstacleWidth,
                    BackColor = ObstacleColor,
                    Location = new Point((listToFill.Last?.Value.Location.X ?? -ObstacleWidth) + ObstacleWidth, locationY),
                };

                listToFill.AddLast(obstacle);

                PlayGround.Controls.Add(obstacle);

            } while (obstacle.Location.X + ObstacleWidth < PlayGround.Width + ObstacleWidth);
        }

        private void ReadyFinalObstacles(LinkedList<Obstacle> obstacles, bool isBottomRow)
        {
            obstacles.Last.Value.Height = ObstacleEqualHeights;
            obstacles.Last.Previous.Value.Height = ObstacleEqualHeights - ObstacleHeightChangeRate;
            obstacles.Last.Previous.Previous.Value.Height = ObstacleEqualHeights - (2 * ObstacleHeightChangeRate);

            if (isBottomRow)
            {
                AdjustBottomObstacleLocationY(obstacles.Last.Value);
                AdjustBottomObstacleLocationY(obstacles.Last.Previous.Value);
                AdjustBottomObstacleLocationY(obstacles.Last.Previous.Previous.Value);
            }
        }

        private void AdjustBottomObstacleLocationY(Obstacle obstacle)
        {
            obstacle.Location = new Point(obstacle.Location.X, PlayGround.Height - obstacle.Height);
        }
    }
}
