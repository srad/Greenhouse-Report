// If entry vCount[x,y] is true then it is counted in the next step
// when searching column-wise for the longest vertical line
var vCount = new bool[with, height];
// Row major traversal
for (int y = 0; y < height; y++)
{
  // For each horizontal pixel interpolate with neighbours
  for (int x = windowSize; x < width - windowSize; x++)
  {
    double sum = 0.0;
    // Horizontal average / interpolation,accepts slight slopes
    for (int k = x - avgWindow; k <= x + avgWindow; k++)
    {
      // Remember, black is 0, to sum black pixel invert them
      sum += 255.0 - srcImage[k];
    }
    double avg = sum / (2 * windowSize + 1);

    // High pass filter: If the neighbourhood black to a certain degree, then count it
    vCount[x, y] = avg > minAvgThreshold;
  }
}