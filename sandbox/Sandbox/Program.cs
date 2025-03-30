using System;

class RoguelikeGame
{
    static char[,] dungeon;
    static int playerX, playerY, playerHealth = 10;
    static int enemyX, enemyY, enemyHealth = 5;
    static Random rand = new Random();

    static void Main()
    {
        InitializeDungeon(10, 10);
        PlacePlayer();
        PlaceEnemy();
        GameLoop();
    }

    static void InitializeDungeon(int width, int height)
    {
        dungeon = new char[width, height];
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                dungeon[x, y] = '.'; // Floor
            }
        }
    }

    static void PlacePlayer()
    {
        playerX = rand.Next(dungeon.GetLength(0));
        playerY = rand.Next(dungeon.GetLength(1));
        dungeon[playerX, playerY] = 'P';
    }

    static void PlaceEnemy()
    {
        do
        {
            enemyX = rand.Next(dungeon.GetLength(0));
            enemyY = rand.Next(dungeon.GetLength(1));
        } while (enemyX == playerX && enemyY == playerY);
        dungeon[enemyX, enemyY] = 'E';
    }

    static void GameLoop()
    {
        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.Clear();
            DrawDungeon();
            Console.WriteLine($"Health: {playerHealth}  Enemy Health: {enemyHealth}");
            ConsoleKeyInfo key = Console.ReadKey();
            MovePlayer(key.Key);
            MoveEnemyTowardsPlayer();
            CheckCombat();
        }
        Console.Clear();
        Console.WriteLine(playerHealth > 0 ? "You defeated the enemy!" : "Game Over!");
    }

    static void DrawDungeon()
    {
        for (int y = 0; y < dungeon.GetLength(1); y++)
        {
            for (int x = 0; x < dungeon.GetLength(0); x++)
            {
                Console.Write(dungeon[x, y] + " ");
            }
            Console.WriteLine();
        }
    }

    static void MovePlayer(ConsoleKey key)
    {
        int newX = playerX, newY = playerY;
        switch (key)
        {
            case ConsoleKey.W: newY--; break;
            case ConsoleKey.S: newY++; break;
            case ConsoleKey.A: newX--; break;
            case ConsoleKey.D: newX++; break;
        }
        if (newX >= 0 && newX < dungeon.GetLength(0) && newY >= 0 && newY < dungeon.GetLength(1))
        {
            dungeon[playerX, playerY] = '.';
            playerX = newX;
            playerY = newY;
            dungeon[playerX, playerY] = 'P';
        }
    }

    static void MoveEnemyTowardsPlayer()
    {
        int newX = enemyX, newY = enemyY;
        if (playerX > enemyX) newX++;
        else if (playerX < enemyX) newX--;
        if (playerY > enemyY) newY++;
        else if (playerY < enemyY) newY--;

        if (newX >= 0 && newX < dungeon.GetLength(0) && newY >= 0 && newY < dungeon.GetLength(1) && (newX != playerX || newY != playerY))
        {
            dungeon[enemyX, enemyY] = '.';
            enemyX = newX;
            enemyY = newY;
            dungeon[enemyX, enemyY] = 'E';
        }
    }

    static void CheckCombat()
    {
        if (playerX == enemyX && playerY == enemyY)
        {
            playerHealth -= rand.Next(1, 4);
            enemyHealth -= rand.Next(1, 4);
            Console.WriteLine("Combat engaged!");
            System.Threading.Thread.Sleep(500);
        }
    }
}
