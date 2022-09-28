function rectangleArea(width, height) {
    if (width < 0 || height < 0) {
      return 'You need positive integers to calculate area!';
    }
    return width * height;
  }
  
  console.log(rectangleArea(-1, 2));

  //rectangleArea(-1, 2);
  //rectangleArea(3,4);