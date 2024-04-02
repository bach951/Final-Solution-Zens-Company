function getAllJokeContentsAPI() {
  fetch("https://joke-content.azurewebsites.net/api/Joke/get-joke-content")
    .then((response) => {
      if (!response.ok) {
        throw new Error("Network response was not ok");
      }
      return response.json();
    })
    .then((data) => {
      console.log(data);
      displayJokeContent(data);
    })
    .catch((error) => {
      console.error("Error:", error);
    });
}

function getJokeContentByIdAPI(id) {
  fetch(
    `https://joke-content.azurewebsites.net/api/Joke/get-joke-content/${id}`
  )
    .then((response) => {
      if (!response.ok) {
        throw new Error("Network response was not ok");
      }
      return response.json();
    })
    .then((data) => {
      console.log(data);
      getJokeContent(data);
    })
    .catch((error) => {
      console.error("Error:", error);
    });
}

function getJokeContents(jokes) {
  const jokeContentElement = document.getElementById("item-joke-content");
  jokes.forEach((joke) => {
    const jokeParagraph = document.createElement("p");
    jokeParagraph.textContent = joke.jokeContent;
    jokeContentElement.appendChild(jokeParagraph);
  });
}

function getJokeContent(joke) {
  const jokeContentElement = document.getElementById("item-joke-content");
  jokeContentElement.textContent = joke.jokeContent;
}

function changeJokeContentFunny() {
  document.getElementById("funny").addEventListener("click", function () {
    incrementAndCallAPI();
  });
}

function changeJokeContentNotFunny() {
  document.getElementById("not-funny").addEventListener("click", function () {
    incrementAndCallAPI();
  });
}

function loadPageInFirstTime() {
  // Call the API function initially with ID 1
  var currentId = localStorage.getItem("currentId");
  if (currentId == null) {
    getJokeContentByIdAPI(1);
  } else {
    getJokeContentByIdAPI(currentId);
  }
}

function reloadPage() {
  if (localStorage.getItem("currentId") != null) {
    resetCurrentId();
  }
}

function resetCurrentId() {
  localStorage.setItem("currentId", 1);
}

function incrementAndCallAPI() {
  // Increment the ID
  let currentId = parseInt(localStorage.getItem("currentId")) || 1;
  if (currentId == 4) {
    alert("That's all the jokes for today! Come back another day!");
    return;
  }
  currentId++;
  localStorage.setItem("currentId", currentId);
  // Call the API function
  getJokeContentByIdAPI(currentId);
}
