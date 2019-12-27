//1. FirstName 不能为空
//2. LastName字符长度不能大于5
//3. Salary不能为空，且应该为数字类型
//4. FirstName 不能包含@字符

function IsFirstNameEmpty() {
    if (document.getElementById("TxtFName").value == "") {
        return "Please Provide First Name.";
    } else { return ""; }
}

function IsFirstNameInValid() {
    if (document.getElementById("TxtFName").value.indexOf("@") != -1) {
        return "First Name Cannot Contains @..";
    } else { return ""; }
}

function IsLastNameValid() {
    if (document.getElementById("TxtLName").value.length >= 20) {
        return "Last Name should not contain more than 5 character.";
    } else { return ""; }
}

function IsSalaryEmpty() {
    if (document.getElementById("TxtSalary").value == "") {
        return "Please Provide Salary";
    } else { return ""; }
}

function IsSalaryValid() {
    if (isNaN(document.getElementById("TxtSalary").value)) {
        return "Enter Valid Salary";
    } else { return ""; }
}


function IsValid() {
    var FirstNameEmptyMessage = IsFirstNameEmpty();
    var FirstNameInValidMessage = IsFirstNameInValid();
    var LastNameInValidMessage = IsLastNameValid();
    var SalaryEmptyMessage = IsSalaryEmpty();
    var SalaryInValidMessage = IsSalaryValid();

    var FinalErrorMessage = "Error:";
    if (FirstNameEmptyMessage != "") {
        FinalErrorMessage += "\n" + FirstNameEmptyMessage;
    }
    if (FirstNameInValidMessage != "") {
        FinalErrorMessage += "\n" + FirstNameInValidMessage;
    }
    if (LastNameInValidMessage != "") {
        FinalErrorMessage += "\n" + LastNameInValidMessage;
    }
    if (SalaryEmptyMessage != "") {
        FinalErrorMessage += "\n" + SalaryEmptyMessage;
    }
    if (SalaryInValidMessage != "") {
        FinalErrorMessage += "\n" + SalaryInValidMessage;
    }
    if (FinalErrorMessage != "Error:") {
        alert(FinalErrorMessage);
        return false;
    } else { return true; }
    console.log("IsValid()Finish");
}

function ResetForm() {
    document.getElementById("TxtFName").value = "";
    document.getElementById("TxtLName").value = "";
    document.getElementById("TxtSalary").value = "";
}