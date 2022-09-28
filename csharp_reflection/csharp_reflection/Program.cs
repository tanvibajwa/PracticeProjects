using System;
using System.Collections.Generic;
using System.Reflection;

namespace csharp_reflection
{
    class HaveMechanics
    {
        public void css(string arg)
        {
            Console.WriteLine($"called HaveMechanics.css with {arg}");
        }
    }

    class ShouldMechanics
    {
        public void equal(string arg)
        {
            Console.WriteLine($"called ShouldMechanics.equal with {arg}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var action_handlers = new Dictionary<string, object>();
            action_handlers.Add("have", new HaveMechanics());
            action_handlers.Add("should", new ShouldMechanics());
            var user_input = Console.ReadLine();       // "have.css:32"

            var elements = user_input.Split('.');
            var action = elements[0];

            if (action_handlers.ContainsKey(action))
            {
                object handler_object = action_handlers[action];
                elements = elements[1].Split(':');
                string method_name = elements[0];
                string value = elements[1];

                call_method(handler_object, method_name, value);
            }
            else
                throw new ArgumentException($"action not found : {action}");


            Console.ReadKey();
        }


        static void call_method(object obj, string method_name, string arg)
        {
            MethodInfo[] methodInfos = obj.GetType().GetMethods(BindingFlags.Public | BindingFlags.Instance);

            foreach(MethodInfo m in methodInfos)
            {
                if (m.Name == method_name)
                {
                    m.Invoke(obj, new object[] { arg });
                    return;
                }
            }

            throw new ArgumentException($"method not found: {method_name}");
        }
    }
}
