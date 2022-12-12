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
            if ((FRONT == 0 && REAR == max - 1) || (FRONT == REAR + 1))
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
                 * IS set to 0 that corresponds to the first position of the array.*/
                if (REAR == max - 1)
                    REAR = 0;
                else
                    /*if Rear is not at the last position, then its values is incremented by one. */
                    REAR = REAR + 1;
            }
            /* once the position of rear is determined, the element is added at its proper place. */
            queue_array[REAR] = element;
        }
            

        public void remove()
        {
            /*Checks whether the queues is empty. */
            if (FRONT == -1)
            {
                Console.WriteLine("Queue undeflow\n");
                return ;
            }
            Console.WriteLine("\nThe Element deleted from queueis; " + queue_array[FRONT] + "\n");
            /*checks if the queue has one elements. */
            if (FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {
                /*if the elements to be deleted is at the last position of the array, then the values
                 * of FRONT is set 0 i.e ti the first element of the array. */
                if (FRONT == max - 1)
                    FRONT = 0;
                else
                    /* front is incremented by one if it is the first is not the first element of array. */
                    FRONT = FRONT + 1;
            }

        }
        
        public void display()
        {
            int FRONT_position = FRONT;
            int REAR_position = REAR;
            
        }

        static void main(string[] args)
        {

        }
    }
}