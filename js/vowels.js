var myString = "An array in a string separated by accomma";
var myArray = myString.split(" ");

const vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];

for(var i=0; i<=myArray.length; i++){
    console.log(myArray[i]);
    console.log("Contains : " + countVowels(myArray[i]) + "vowels")
    
}

function countVowels(sentence) {
  let counts = 0;
  for(let i = 0; i < vowels.length; i++) {
    if(vowels.includes(sentence[i])) {
      counts++;
    }
  }
  return console.log(counts);
}

function PrintVowelPerWord(myArray){
    for(var i=0; i<=myArray.length; i++){
        console.log(myArray[i]);
        console.log("Contains : " + countVowels(myArray[i]) + "vowels")
        
    }
}


PrintVowelPerWord(myArray);