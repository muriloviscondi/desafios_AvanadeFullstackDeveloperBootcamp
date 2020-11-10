let readIn = gets()
let read = gets()

const words = []

while (readIn !== "") {
  words.push({
    "letter": readIn.split(""), 
    "treatedLetter": read.split("")
  })
  readIn = gets()
  read = gets()
}

words.forEach(word => {
  let count = 0
  const {letter, treatedLetter} = word
  
  letter.forEach(i => {
    treatedLetter.forEach(j => {
      if(i === j) {
        count++;
      }
    })
  })
  console.log(count)
})