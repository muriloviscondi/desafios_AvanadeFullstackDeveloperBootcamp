let readIn = gets()
let read = gets()

const words = []

while (readIn !== "") {
  words.push({
    "letter": readIn.normalize("NFD").replace(/[^0-9a-zA-Z]/g, "").split(""), 
    "treatedLetter": read.normalize("NFD").replace(/[^0-9a-zA-Z]/g, "").split("")
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






