const url = "http://localhost:3030/jsonstore/collections/students";

function start() {
  const firstName = document.querySelector('input[name="firstName"]');
  const lastName = document.querySelector('input[name="lastName"]');
  const facultyNumber = document.querySelector('input[name="facultyNumber"]');
  const grade = document.querySelector('input[name="grade"]');
  const tableElement = document.querySelector("table tbody");

  const formElement = document.getElementsByTagName("form")[0];
  formElement.addEventListener("submit", onSubmit);

  async function onSubmit(e) {
    e.preventDefault();

    const data = new FormData(formElement);

    if (
      typeof firstName.value != "string" ||
      firstName.value.length === 0 ||
      firstName.value === ""
    ) {
      return;
    }

    if (
      (typeof lastName.value != "string" && lastName.value.length === 0) ||
      lastName.value === ""
    ) {
      return;
    }

    const numberBool = containsOnlyNumbers(facultyNumber.value);
    const gradeBool = containsOnlyNumbers(grade.value);

    if (
      isNaN(facultyNumber.value) ||
      facultyNumber.value.length === 0 ||
      !numberBool
    ) {
      return;
    }

    if (isNaN(grade.value) || grade.value.length === 0 || !gradeBool) {
      return;
    }

    await fetch(url, {
      method: "post",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({
        firstName: firstName.value,
        lastName: lastName.value,
        facultyNumber: facultyNumber.value,
        grade: grade.value,
      }),
    });

    visualizeStudents();

    firstName.value = "";
    lastName.value = "";
    facultyNumber.value = "";
    grade.value = "";
    tableElement.innerHTML = "";
  }

  function containsOnlyNumbers(str) {
    let flag = true;

    for (const letter of str) {
      if (
        letter !== "1" &&
        letter !== "2" &&
        letter !== "3" &&
        letter !== "4" &&
        letter !== "5" &&
        letter !== "6" &&
        letter !== "7" &&
        letter !== "8" &&
        letter !== "9" &&
        letter !== "0"
      ) {
        flag = false;
        break;
      }
    }

    return flag;
  }

  async function visualizeStudents() {
    const response = await fetch(url);
    const data = await response.json();

    Object.values(data).map((s) => {
      let tr = document.createElement("tr");

      let thFirstName = document.createElement("th");
      thFirstName.textContent = s.firstName;

      let thLastName = document.createElement("th");
      thLastName.textContent = s.lastName;

      let thFacultyNumber = document.createElement("th");
      thFacultyNumber.textContent = s.facultyNumber;

      let thGrade = document.createElement("th");
      thGrade.textContent = s.grade;

      tr.appendChild(thFirstName);
      tr.appendChild(thLastName);
      tr.appendChild(thFacultyNumber);
      tr.appendChild(thGrade);

      tableElement.appendChild(tr);
    });
  }
}

start();