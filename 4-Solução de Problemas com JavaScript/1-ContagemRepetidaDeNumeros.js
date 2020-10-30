let casesIn = gets();
let numbers = [];

for(let i = 0; i < casesIn; i++){
  numbers.push(gets());
}

const occurrences = numbers.filter((value, index, number) => {
  return number.indexOf(value) === index;
}).sort((a, b) => a - b);

for(occurrence of occurrences){
  let count = numbers.reduce((acc, cur) => {
    if(occurrence === cur){
      acc++;
    }
    return acc;
  }, 0);

  console.log(`${occurrence} aparece ${count} vez(es)`);
}