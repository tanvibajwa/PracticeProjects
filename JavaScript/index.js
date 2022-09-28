let name = 'Shawn';
const piValue = 3.14;
console.log(piValue);
console.log(name);

//object fridge with its properties
let fridge = {
    brand : 'samsung',
    make : 2021,
    compartments : 4,
    choiceOfColours : ['grey', 'black']
};

fridge.compartments = 5;

console.log(fridge.compartments);
console.log(fridge.choiceOfColours[0]);

console.log(fridge.choiceOfColours.length);

function add(number1, number2)
{
    return number1 + number2;
}

console.log(add(1,2));
console.log(add(2,4));