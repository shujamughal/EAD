
            /***********************/
            int a = 10, b = 5;
            var option = "+";

            var output = option switch
            {
                "+" => a + b,
                "-" => a - b,
                _ => a * b
            };
            Console.WriteLine("Example 1 : " + output);

            /***********************/
            var value = 51;

            int example3 = value switch
            {
                _ when value < 10 => 0,
                _ when value > 10 &&  value < 50 => 1,
                _ => 100
            };
            Console.WriteLine("Example 2 : " + example3);


            object[] myObjects = { 1, 2, "hello", 2.35, true, null, 3.4f};
            var j = 10;
            foreach (var q in myObjects)
            {
                dynamic thisObject = q switch
                {
                    float f => j+3,
                    string s => $"it is a string {s}",
                    double d => $"it is a double {d}",
                    //double d when d ==2.36 => $"it is a double {d}",
                    bool bb => $"it is a boolean {bb}",
                    int k => $"it is an integer {k}",
                    null => $"this is null value in switch expression",
                    _ => "defaul value",
                    

                };
                Console.WriteLine(thisObject);
            }//foreach