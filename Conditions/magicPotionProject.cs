
// Magic potion project

int temperature = 78;
int toxicity = 40;
int colorCode = 5;
int glowLevel = 6;
int baseScore = (100 - toxicity) + glowLevel * 3 - Math.Abs(colorCode - 7) * 2;

bool isSuccessful = baseScore > 80;
bool isDangerous = toxicity > 70 || temperature > 90;
bool isRare = glowLevel > 7 && colorCode == 7;
bool isApproved = isSuccessful &&! isDangerous;
bool isImproved = toxicity < 30 && glowLevel >= 8 && temperature > 65 && temperature < 85;

if (isApproved && isRare)
{
    baseScore += 10;
}
if (Math.Abs(temperature - toxicity) > 50)
{
    baseScore -= 5;
}
if (glowLevel == colorCode)
{
    baseScore += 7;
}
if (temperature > 100)
{
    baseScore -= 15;
}
if (isImproved)
{
    baseScore += 12;
}


string data = "";
if (isSuccessful)
{
    data += "Successful\n";
}
if (isDangerous)
{
    data += "Dangerous\n";
}
if (isRare)
{
    data += "Rare\n";
}
if (isApproved)
{
    data += "Approved\n";
}
if (isSuccessful)
{
    data += "Improved\n";
}

Console.WriteLine($"Score: {baseScore}\nPotion data:\n{data}");