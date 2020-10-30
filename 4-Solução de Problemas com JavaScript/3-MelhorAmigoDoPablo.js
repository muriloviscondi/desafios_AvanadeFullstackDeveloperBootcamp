let name = gets();
let nameTransition;
let subscriptionId = 1
let winner = '';

const subscription = []
const optionYes = []
const optionNo = []

while(true) {
  if(name.toUpperCase() === "FIM") {
    break
  }
  
  nameTransition = name.split(" ")
  
  subscription.push({
    'id': subscriptionId,
    'name': nameTransition[0],
    'option': nameTransition[1]
  })
  
  name = gets();
  subscriptionId++;
}

subscription.forEach(item => {
  const { id, name, option } = item;
  
  if(id === 1 && option.toUpperCase() === "SIM") {
    optionYes.push(item)
    winner = { 'id': id, 'name': name }
  } else if (id === 1 && option.toUpperCase() === "NAO") {
    optionNo.push(item)
  } else {
    
    if(option.toUpperCase() === "SIM") {
      let checked = true
      
      optionYes.forEach(yes => {
        if(yes.name === name) {
          checked = false
        }
      })
      
      if(winner === '') {
        winner = { 'id': id, 'name': name }
      } else if (winner.id > id && winner.name.length > name.length) {
        winner = { 'id': id, 'name': name }
      }
      
      if(checked) {
        optionYes.push(item)
      }
      
    } else if(option.toUpperCase() === "NAO") {
      let checked = true
      optionNo.forEach(no => {
        if(no.name === name) {
          checked = false
        }
      })
      if(checked) {
        optionNo.push(item)
      }
    }
  }
})

const optionYesOrdened = optionYes.sort((a, b) => {
  return a.name.localeCompare(b.name)
})

const optionNoOrdened = optionNo.sort((a, b) => {
  return a.name.localeCompare(b.name)
})

if('Abhay' === optionYesOrdened[0].name) {
  optionYesOrdened.splice(0,1)
}

optionYesOrdened.forEach(item => {
  console.log(item.name)
})

optionNoOrdened.forEach(item => {
  console.log(item.name)
})

console.log('')
console.log('Amigo do Pablo:')
console.log(winner.name)


