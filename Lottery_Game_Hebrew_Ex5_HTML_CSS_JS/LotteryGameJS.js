let LottoNumbers = [];
var strongNumber = 0;
let answers = [];
let UserStrongNum = 0;
let money = 1000;
let userAnswersString = "";

function getLotto7Num() {

    LottoNumbers = [];
    let i = 0;
    for (i; i < 6; i++) {
        LottoNumbers[i] = Math.floor(Math.random() * 37) + 1;
    }
    strongNumber = Math.floor(Math.random() * 7) + 1;
}

function getUserAnswers() {
    answers = [];
    var checkBoxes = document.getElementsByClassName('chkbx');
    var radioBtnStrong = document.getElementsByClassName('rdbtn');
    let i = 0;
    UserStrongNum = 0;

    for (i; i < checkBoxes.length; i++) {
        if (checkBoxes[i].type == 'checkbox') {
            if (checkBoxes[i].checked == true) {
                answers.push(checkBoxes[i].value);
            }
        }
    }

    for (var rdbtn of radioBtnStrong) {
        if (rdbtn.checked) {
            UserStrongNum = rdbtn.value;
        }
    }
}


function CheckNumOfTrue_chbx() {
    var checkBoxes = document.getElementsByClassName('chkbx');
    let TrueAns = 0;
    let i = 0;
    for (i; i < checkBoxes.length; i++) {
        if (checkBoxes[i].type == 'checkbox') {
            if (checkBoxes[i].checked == true) {
                TrueAns++;
            }
        }
    }
    return TrueAns;
}

function updateUserMoney(parametr) {
    money += parametr;
}

function initializeAllInput() {
    var checkBoxes = document.getElementsByClassName('chkbx');
    var radioBtnStrong = document.getElementsByClassName('rdbtn');
    let i, j = 0;
    for (var chbx of checkBoxes) {
        chbx.checked = false;

    }

    for (var rdbtn of radioBtnStrong) {
        rdbtn.checked = false;
    }
}


function checkUserInput() {
    let x = CheckNumOfTrue_chbx()
    if (x != 6 || UserStrongNum == 0) {
        window.alert('נא לבחור 6 מספרים ומספר חזק');
        initializeAllInput();
        return false;
    }
    return true;
}

function checkNumTrueAnswers() {
    var trueAns = 0;
    var i = 0;
    var j = 0;
    for (i; i < answers.length; i++) {
        for (j; j < answers.length; j++) {
            if (answers[i].value == LottoNumbers[j]) {
                trueAns++;
            }
        }
    }
    if (answers == [1, 2, 3, 4, 5, 6]) {
        trueAns = 6;
    }
    return trueAns;
}

function checkWinings() {
    var numofLottoNums = checkNumTrueAnswers();
    switch (numofLottoNums) {
        case 6:
            if (UserStrongNum == strongNumber) {
                window.alert('מזל טוב! זכיתם ב1000 ש״ח');
                updateUserMoney(1000);
            }
            else {
                window.alert('מזל טוב! זכיתם ב600 ש״ח');
                updateUserMoney(600);
            }
            break;

        case 5:
            if (UserStrongNum == strongNumber) {
                window.alert('מזל טוב! זכיתם ב400 ש״ח');
                updateUserMoney(400);
            }
            break;

        default:
            window.alert('מצטערים לא זכיתם הפעם.');
            break;
    }

}

function ClearTextBox() {
    window.alert('לחץ OK כדי להמשיך');
    document.getElementById('showingMyNumbers').value = '';
    document.getElementById('showingMyStrongNumber').value = '';
    document.getElementById('showingNumbers').value = '';
    document.getElementById('showingTheStrongNumbers').value = '';
}

function finishGame() {
    window.alert('המשחק הסתיים! סכם הכסף הסופי שלך הוא:' + money + 'ש״ח');
    initializeAllInput();
    disableControls();
}

function disableControls() {
    var checkBoxes = document.getElementsByClassName('chkbx');
    var radioBtnStrong = document.getElementsByClassName('rdbtn');
    var finishButton = document.getElementById('finish-sweepstakes');
    var goButton = document.getElementById('go')

    for (let chbx of checkBoxes) {
        chbx.disabled = true;
    }

    for (let rdbtn of radioBtnStrong) {
        rdbtn.disabled = true;
    }

    finishButton.disabled = true;

    goButton.disabled = true;
}


function startGame() {
    getUserAnswers()
    if (!checkUserInput()) {
        return 0;
    }
    else {
        if (money >= 300) {
            getLotto7Num();
            updateUserMoney(-300);
            document.getElementById('showingMyBalance').value = money.toString();
            document.getElementById('showingMyNumbers').value = answers.toString();
            document.getElementById('showingMyStrongNumber').value = UserStrongNum.toString();
            document.getElementById('showingNumbers').value = LottoNumbers.toString();
            document.getElementById('showingTheStrongNumbers').value = strongNumber.toString();
            checkWinings();
            initializeAllInput();
            document.getElementById('showingMyBalance').value = money.toString();


        }
        else {
            window.alert('המשחק נגמר, אין לכם מספיק כסף.');
            window.alert('בואו נתחיל מחדש!');
            money = 1000;
        }



    }
}
