using System;
using System.Collections.Generic;
using Raylib_cs;

namespace RayLibPractice
{
    class Director
    {

        private bool _gameIsRunning = true;
        OutputService _outputService = new OutputService();
        InputService _inputService = new InputService();
        ScoreBoard _scoreBoard = new ScoreBoard();
        Point _gravity = new Point(0,1);
        PhysicsService _collision = new PhysicsService();
        Player _player = new Player();
        Enemy _enemy = new Enemy();
        Enemy _enemy2 = new Enemy();
        Enemy _enemy3 = new Enemy();
        Enemy _enemy4 = new Enemy();
        Enemy _enemy5 = new Enemy();

        public void StartGame()
        {
            PrepareGame();
            
            while(_gameIsRunning)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
                if(_inputService.IsWindowClosing())
                {
                    _gameIsRunning = false;
                }
            }
            Console.WriteLine("Game Over");
            Console.WriteLine($"Your High Score is {_scoreBoard._score}");

        }

        private void PrepareGame()
        {
            _outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, Constants.TITLE, Constants.FRAME_RATE);
        }

        private void GetInputs()
        {
            if(_inputService.IsLeftKeyPressed())
            {
                _player._velocity = _inputService.GetDirection();
                _player._velocity._x *= Constants.PLAYER_SPEED;
                _player.MoveNext();
            }

            else if(_inputService.IsRightKeyPressed())
            {
                _player._velocity = _inputService.GetDirection();
                _player._velocity._x *= Constants.PLAYER_SPEED;
                _player.MoveNext();
            }
            else if(_inputService.IsDownKeyPressed())
            {
                _player._velocity = _inputService.GetDirection();
                _player._velocity._y *= Constants.PLAYER_SPEED;
                _player.MoveNext();
            }
            else if(_inputService.IsUpKeyPressed())
            {
                _player._velocity = _inputService.GetDirection();
                _player._velocity._y *= Constants.PLAYER_SPEED;
                _player.MoveNext();
            }

        }

        private void DoUpdates()
        {
            _enemy.MoveNext();
            _enemy2.MoveNext();
            _enemy3.MoveNext();
            _enemy4.MoveNext();
            _enemy5.MoveNext();

            if(_collision.IsCollision(_player, _enemy))
            {
                _scoreBoard._score -= Constants.SCORE_REMOVE;
                _player._lives --;
                _scoreBoard._text = $"Score: {_scoreBoard._score} Lives {_player._lives}";
                _enemy.UpdateActor();            
            }
            if(_collision.IsCollision(_player, _enemy2))
            {
                _scoreBoard._score -= Constants.SCORE_REMOVE;
                _player._lives --;
                _scoreBoard._text = $"Score: {_scoreBoard._score} Lives {_player._lives}";
                _enemy2.UpdateActor();
            }
            if(_collision.IsCollision(_player, _enemy3))
            {
                _scoreBoard._score -= Constants.SCORE_REMOVE;
                _player._lives --;
                _scoreBoard._text = $"Score: {_scoreBoard._score} Lives {_player._lives}";
                _enemy3.UpdateActor();
            }
            if(_collision.IsCollision(_player, _enemy4))
            {
                _scoreBoard._score -= Constants.SCORE_REMOVE;
                _player._lives --;
                _scoreBoard._text = $"Score: {_scoreBoard._score} Lives {_player._lives}";
                _enemy4.UpdateActor();
            }
             if(_collision.IsCollision(_player, _enemy5))
            {
                _scoreBoard._score -= Constants.SCORE_REMOVE;
                _player._lives --;
                _scoreBoard._text = $"Score: {_scoreBoard._score} Lives {_player._lives}";
                _enemy5.UpdateActor();
            }

            if(_enemy.IsOffScreen())
            {
                _scoreBoard._score += Constants.SCORE_ADD;
                _scoreBoard._text = $"Score: {_scoreBoard._score} Lives {_player._lives}";
                _enemy.UpdateActor();
            }
            if(_enemy2.IsOffScreen())
            {
                _scoreBoard._score += Constants.SCORE_ADD;
                _scoreBoard._text = $"Score: {_scoreBoard._score} Lives {_player._lives}";
                _enemy2.UpdateActor();
            }
            if(_enemy3.IsOffScreen())
            {
                _scoreBoard._score += Constants.SCORE_ADD;
                _scoreBoard._text = $"Score: {_scoreBoard._score} Lives {_player._lives}";
                _enemy3.UpdateActor();
            }
            if(_enemy4.IsOffScreen())
            {
                _scoreBoard._score += Constants.SCORE_ADD;
                _scoreBoard._text = $"Score: {_scoreBoard._score} Lives {_player._lives}";
                _enemy4.UpdateActor();
            }
            if(_enemy5.IsOffScreen())
            {
                _scoreBoard._score += Constants.SCORE_ADD;
                _scoreBoard._text = $"Score: {_scoreBoard._score} Lives {_player._lives}";
                _enemy5.UpdateActor();
            }

            if(_player._lives <= 0)
            {
                _gameIsRunning = false;
            }

            if(_scoreBoard._score > 3000)
            {
                _enemy.HardMode();
                _enemy2.HardMode();
                _enemy3.HardMode();
                _enemy4.HardMode();
                _enemy5.HardMode();
                _scoreBoard._text = $"Score: {_scoreBoard._score} Lives {_player._lives} HARD MODE ACTIVATED!!!";
            }

        }

        private void DoOutputs()
        {
            _outputService.StartDrawing();
            _outputService.DrawActor(_player);
            _outputService.DrawActor(_scoreBoard);
            _outputService.DrawActor(_enemy);
            _outputService.DrawActor(_enemy2);
            _outputService.DrawActor(_enemy3);
            _outputService.DrawActor(_enemy4);
            _outputService.DrawActor(_enemy5);
            _outputService.EndDrawing();
        }
    }
}
