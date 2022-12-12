using System;

namespace CircularQueues
{
    class program
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];

        public program()
        {
            //initializing the values of the variables REAR and FRONT to -1 to indicate that the queue is in initially empty
            FRONT = -1;
            REAR = -1;
        }

        public void insert(int element)
        {
            /*this statement checks for the overflow condition. */
            if ((FRONT == 0 && REAR == max - 1) ||(FRONT == REAR +1))
            {
                Console.WriteLine("\nQueues overflow\n");
                return;
            }
            /* the following statement check whether queues is empty. if the queue is
             * empty, the the value of the REAR and FRONT variables is set to 0. */
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {
                /*if REAR is at the last position of the array, then the value of REAR
                 * IS SET 
            }
        }

        static void main(string[] args)
        {

        }
    }
}