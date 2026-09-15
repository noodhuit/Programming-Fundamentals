double ind1 = 14.5;
double ind2 = 15.5;
double project = 17.0;
double projectParticipation = 1.0;
double attendance = 0.75;

double FinalGrade = (ind1 * 0.25) + (ind2 * 0.25) +
                    (project * projectParticipation * 0.5);

if (attendance < 0.7){
    Console.WriteLine("Failed for Low attendance");
}
else {
    Console.WriteLine($"Final Grade: {FinalGrade:F0}");
    if (FinalGrade >= 9.5){
        Console.WriteLine("Pass! :)");

    }
    else{
        Console.WriteLine("Fail :)");
    }
}