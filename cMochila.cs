


namespace tp_final
{
    public class cMochila
    {
        public class Item
        {
            public int Weight { get; set; }
            public int Value { get; set; }
        }
        public static List<Pedido> KnapSack(Pedido[] items, int capacity, int carga)
        {
            int[,] matrix = new int[items.Length + 1, capacity + 1];
            List<Pedido>[,] matrix2 = new List<Pedido>[items.Length + 1, capacity + 1];
            
            for (int i = 0; i < items.Length + 1; i++)
            {
                for (int j = 0; j < capacity + 1; j++)
                    matrix2[i, j] = new List<Pedido>();
            }
            
            for (int itemIndex = 0; itemIndex <= items.Length; itemIndex++)//selecciona un pedido
            {
                // This adjusts the itemIndex to be 1 based instead of 0 based
                // and in this case 0 is the initial state before an item is
                // considered for the knapsack.
                var currentItem = itemIndex == 0 ? null : items[itemIndex - 1];//capacity=volumen
                int carga_aux = carga;
                for (int currentCapacity = 0; currentCapacity <= capacity; currentCapacity++)
                {
                    // Set the first row and column of the matrix to all zeros
                    // This is the state before any items are added and when the
                    // potential capacity is zero the value would also be zero.
                    if (currentItem == null || currentCapacity == 0)
                    {
                        matrix[itemIndex, currentCapacity] = 0;
                    }
                    // If the current items weight is less than the current capacity
                    // then we should see if adding this item to the knapsack 
                    // results in a greater value than what was determined for
                    // the previous item at this potential capacity.
                    else if (currentItem.volumen_casteado <= currentCapacity)
                    {
                        int a = currentItem.peso_casteado
                                + matrix[itemIndex - 1, currentCapacity - currentItem.volumen_casteado];
                        int b = matrix[itemIndex - 1, currentCapacity];
                        if (a > b && currentItem.peso_casteado<carga_aux)
                        {
                            carga_aux=currentItem.peso_casteado;
                            matrix2[itemIndex, currentCapacity] = matrix2[itemIndex - 1, currentCapacity - currentItem.volumen_casteado].ToList();
                            matrix2[itemIndex, currentCapacity].Add(currentItem);



                        }
                        else
                            matrix2[itemIndex, currentCapacity] = matrix2[itemIndex - 1, currentCapacity];

                        matrix[itemIndex, currentCapacity] = Math.Max(
                            currentItem.peso_casteado
                                + matrix[itemIndex - 1, currentCapacity - currentItem.volumen_casteado],
                            matrix[itemIndex - 1, currentCapacity]);

                    }
                    // current item will not fit so just set the value to the 
                    // what it was after handling the previous item.
                    else
                    {
                        matrix[itemIndex, currentCapacity] =
                            matrix[itemIndex - 1, currentCapacity];
                        matrix2[itemIndex, currentCapacity] = matrix2[itemIndex - 1, currentCapacity];
                    }
                }
            }

            // The solution should be the value determined after considering all
            // items at all the intermediate potential capacities.
            Console.WriteLine(matrix[items.Length, capacity]);
            Console.WriteLine(matrix2[items.Length, capacity].Count);

            return matrix2[items.Length, capacity];
        }


    }
}

   
