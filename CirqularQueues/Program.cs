using System;

namespace CircularQueues
{
    class Program
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];

        public Program()
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
            /*CHECKS if the queue is empty. */
            if (FRONT == -1)
            {
                Console.WriteLine("Queue is empty\n");
                return;
            }
            Console.WriteLine("\nElements in the queue are ....................\n");
            if (FRONT_position <= REAR_position)
            {
                /* traverses the queue till the last elements present in an array. */
                while (FRONT_position <=REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "   ");
                    FRONT_position++;

                }
                Console.WriteLine();
            }
            else
            {
                /* traverses the queue till the last position of the array. */
                while (FRONT_position <= max -1)
                {
                    Console.Write(queue_array[FRONT_position] + "   ");
                    FRONT_position++;
                }
                /* SET THE FRONT position to the first element of the array. */
                FRONT_position = 0;
                /* traverses the array till the last elements present in the queue. */
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "    ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
        }

        static void main(string[] args)
        {
            Program queue = new Program();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("MENU");
                    Console.WriteLine("1. implement insert operation");
                    Console.WriteLine("2. Implement Delete Operation");
                    Console.WriteLine("3. Display Values");
                    Console.WriteLine("4. EXIT ");
                    Console.Write("\nEnter your choice (1-4): ");
                    ch = Convert.ToChar(Console.Read());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.Write("Enter a number:  ");
                                int num = Convert.ToInt32(System.Console.ReadLine());
                                Console.WriteLine();
                                queue.insert(num);
                            }
                            break;

                        case '2':
                            {
                                queue.remove();
                            }
                            break;
                        case '3':
                            {
                                queue.display();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("invlaid option !!");
                            }
                            break;
                    }  
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered. ");
                }
            }
        }
    }
}