﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePractice.Queue
{
    public class QueueUsingCircularArray3
    {
        private object[] a;
        private int front = 0;
        private int rear = 0;
        public int Count { get; private set; } = 0;

        public QueueUsingCircularArray3(int queueSize)
        {
            a = new object[queueSize];
        }

        public void Enqueue(object data)
        {
            if(Count == a.Length)
            {
                throw new ApplicationException("Full");
            }

            a[rear] = data;
            rear = (rear + 1) % a.Length;
            Count++;
        }

        public object Dequeue()
        {
            if(Count == 0)
            {
                throw new ApplicationException("Empty");
            }

            object data = a[front];
            front = (front + 1) % a.Length;
            Count--;
            return data;
        }
    }
}
