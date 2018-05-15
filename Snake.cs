using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace snakeGame
{
    enum Direction {up, right, down, left }
    class Snake
    {
        //Variables
        Direction direction;
        int speed;
        List<Rectangle> body;
        Canvas canvas;
        Window window;

        //Constructor
        public Snake(Canvas c, Window w)
        {
            canvas = c;
            window = w;
            body = new List<Rectangle>();
            Rectangle temp = new Rectangle();
            temp.Fill = Brushes.Red;
            temp.Width = 10;
            temp.Height = 10;
            body.Add(temp);
            for (int i = 0; i < body.Count; i++)
            {
                canvas.Children.Add(body[i]);
                Canvas.SetTop(body[i], 0);
                Canvas.SetLeft(body[i], 0);
            }
            direction = Direction.right;

        }

        public void update()
        {
            if (direction == Direction.right)
            {
                Rectangle temp = new Rectangle();
                temp.Fill = Brushes.Red;
                temp.Width = 10;
                temp.Height = 10;
                body.Add(temp);
                canvas.Children.Add(body[body.Count - 1]);
                double x = Canvas.GetLeft(body[body.Count - 2]);
                Canvas.SetTop(body[body.Count - 1], Canvas.GetTop(body[body.Count - 2]));
                Canvas.SetLeft(body[body.Count - 1], Canvas.GetLeft(body[body.Count - 2]) + 10);
                foreach (Rectangle r in canvas.Children) {
                    //Console.WriteLine(Canvas.get)
                }
                Console.WriteLine(canvas.Children.Count);
                canvas.Children.Remove(body[0]);
                body.RemoveAt(0);
            }
            
        }

        internal void grow()
        {
            if (direction == Direction.right)
            {
                Rectangle temp = new Rectangle();
                temp.Fill = Brushes.Red;
                temp.Width = 10;
                temp.Height = 10;
                body.Add(temp);
                canvas.Children.Add(body[body.Count - 1]);
                Canvas.SetTop(body[body.Count - 1], Canvas.GetTop(body[body.Count - 2]));
                Canvas.SetLeft(body[body.Count - 1], Canvas.GetLeft(body[body.Count - 2]) + 10);
            }
        }
        }
    }
