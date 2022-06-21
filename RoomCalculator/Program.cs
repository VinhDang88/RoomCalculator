Console.WriteLine("What is the length of the classroom?");

decimal length = decimal.Parse(Console.ReadLine());

Console.WriteLine("What is the width of the classroom?");

decimal width = decimal.Parse(Console.ReadLine());

decimal perimeter = (length + width) * 2;
decimal area = (length * width);


Console.WriteLine("The area of the classroom is: " + area);
Console.WriteLine("The perimeter of the classrrom is: " + perimeter);

//Build Specifications:
//1 Point: Assume that the rooms are perfect rectangles.
//1 Point: Assume that the user will enter valid numeric data for length and width.
//1 Point: The application should accept decimal entries.

if (area <= 250)
    Console.WriteLine("The room is small");
else if (area < 650 && area > 250)
    Console.WriteLine("The room is medium");
else if (area >= 650)
    Console.WriteLine("The room is large");

Console.WriteLine("What is the height of the classroom?");

decimal height = decimal.Parse(Console.ReadLine());

decimal volume = (length * width * height);

decimal surfaceArea = (length * width)*2 + 2*(width * height) + 2*(length * height);

Console.WriteLine("Volume of the room: " + volume);
Console.WriteLine("Surface area of the room: " + surfaceArea);

