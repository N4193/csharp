## CSharp
Welcome to C#(CSharp) homework Track.
    This Track From Exercism Website is Completed By @N4193 (nnaigeon@outlook.fr)

## Introduction
This is a simple C# folder with my homework to proof my skill to myself.☺
One folder a time you can test the code by using the "dotnet test" command 

## What's here ?
some folder to learn C# lang 
- annalyns-infiltration             -> Opperator "&&" and "||" 
- bird-watcher                      -> Array[]
- booking-up-for-beauty             -> DateTime & Parse()
- calculator-conundrum              -> execption & try | catch 
- cars-assemble                     -> Comparator & Logic algorithm
- hello-world                       -> The first one you know ♥
- hyper-optimized-telemetry         -> integer.MinValue/.MaxValue
- interest-is-interesting           -> Float variable & While() loop   
- International Calling Connoisseur -> Dictionaries
- leap                              -> algo reflecrion and short if?yes:no
- log-analysis                      -> String type & Split() 
- log-levels                        -> String type & Trim(),IndexOf()
- logs-logs-logs                    -> enum & more split train
- lucians-luscious-lasagna          -> Int type & Logic algorithm
- motorbike                         ->  Todo ,not implemented now 
- need-for-speed                    -> class & constructor
- phone-number-analysis             -> Analyse Array[] & Split()
- ReverseString                     -> String & Arrays[] & loop & more 
- roll-the-die                      -> Random()
- RotationalCipher                  -> The Caesar cipher algoritme !☺
- SecureMunchesterUnited            -> operator "is" to compare classObject
- squeaky-clean                     -> Char & StringBluider()
- the-weather-in-deather            -> fator a lot the code ! 
- tim-from-marketing                -> nullable type + StringBluider()
- todoListProject                   ->  Comming soon
- WeighingMachine                   -> class proprety{get;set}
- wizard-and-warriors               -> Class and Inheritance
- wizards-and-warriors-2            -> _Method overloading_ & default value 

## Source
- @N4193

## Special thank's to ppl create exercises to solve 
- @yzAlvin
- @ErikSchierboom
- @valentin-p
- @mikedamay
- @j2jensen
- @robkeim
- @maurelio1234
- @aage
- @sanderploegsma
- @bressain
- @jwood803
- @kytrinyx
- @NextNebula
- @wolf99
- @sanderploegsma

//sorry for ppl i forget here i love you a lot ♥

## C#-EZcheatSheet / toolbox
    //output the proprety "year" from Variable "toto"
    Console.WriteLine(toto.year);

    //output the type of the proprety "year" from Variable "toto"
    Console.WriteLine(toto.year.GetType());

    //factor little if statement for return
    //memo : is_this_condition_true ? yes : no
    condition ? consequent : alternative

    /*
    I build lil dirty tool to scan _CHANGE_ME proprety & method()  /!\
    object MyVarToInspect = _CHANGE_ME;           
    if (MyVarToInspect == null) Console.WriteLine("null object");
        Console.WriteLine($"object: {MyVarToInspect}");
        var type = MyVarToInspect.GetType(); 
        foreach (var method in type.GetMethods())
        {
            Console.WriteLine($"Method: {method.Name}()");
        }
        foreach (var prop in type.GetProperties())
        {
            if (prop.PropertyType == typeof(string))
            {
                var value = prop.GetValue(MyVarToInspect)?.ToString();
                if (!string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine($"valeurs : {value}");
                }
            }
        }
    */
