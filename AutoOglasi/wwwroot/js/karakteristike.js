// karakteristike brend/model
function popuniModele() {
    var brand = document.getElementById("Brand").value;
    var modelDropdown = document.getElementById("Model");
    modelDropdown.innerHTML = "";

    if (brand === "Suzuki") {
        var models = [
            "Alto",
            "Baleno",
            "Celerio",
            "Ignis",
            "Jimny",
            "S-Cross",
            "Splash",
            "Swift",
            "SX4",
            "Vitara"
        ];
        models.forEach(function (model) {
            var option = document.createElement("option");
            option.text = model;
            modelDropdown.add(option);
        });
    } else if (brand === "Audi") {
        var models = [
            "A1",
            "A3",
            "A4",
            "A5",
            "A6",
            "A7",
            "A8",
            "Q2",
            "Q3",
            "Q5",
            "Q7",
            "Q8",
            "R8",
            "TT"
        ];
        models.forEach(function (model) {
            var option = document.createElement("option");
            option.text = model;
            modelDropdown.add(option);
        });
    } else if (brand === "Peugeot") {
        var models = [
            "108",
            "108 Top!",
            "2008",
            "208",
            "3008",
            "308",
            "5008",
            "508",
            "508 SW",
            "Traveller"
        ];
        models.forEach(function (model) {
            var option = document.createElement("option");
            option.text = model;
            modelDropdown.add(option);
        });
    } else if (brand === "Mercedes-Benz") {
        var models = [
            "A-Class",
            "B-Class",
            "C-Class",
            "CLA-Class",
            "CLS-Class",
            "E-Class",
            "G-Class",
            "GLA-Class",
            "GLB-Class",
            "GLC-Class",
            "GLE-Class",
            "GLS-Class",
            "S-Class",
            "SL-Class",
            "SLC-Class",
            "V-Class",
            "X-Class"
        ];
        models.forEach(function (model) {
            var option = document.createElement("option");
            option.text = model;
            modelDropdown.add(option);
        });
    } else if (brand === "BMW") {
        var models = [
            "1 Series",
            "2 Series",
            "3 Series",
            "4 Series",
            "5 Series",
            "6 Series",
            "7 Series",
            "8 Series",
            "i3",
            "i8",
            "M2",
            "M3",
            "M4",
            "M5",
            "M6",
            "X1",
            "X2",
            "X3",
            "X4",
            "X5",
            "X6",
            "X7",
            "Z4"
        ];
        models.forEach(function (model) {
            var option = document.createElement("option");
            option.text = model;
            modelDropdown.add(option);
        });
    } else if (brand === "Mazda") {
        var models = [
            "2",
            "3",
            "6",
            "CX-3",
            "CX-30",
            "CX-5",
            "CX-8",
            "CX-9",
            "MX-5 Miata",
            "MX-30"
        ];
        models.forEach(function (model) {
            var option = document.createElement("option");
            option.text = model;
            modelDropdown.add(option);
        });
    } else if (brand === "Skoda") {
        var models = [
            "Citigo",
            "Fabia",
            "Kamiq",
            "Karoq",
            "Kodiaq",
            "Octavia",
            "Rapid",
            "Scala",
            "Superb",
            "Yeti"
        ];
        models.forEach(function (model) {
            var option = document.createElement("option");
            option.text = model;
            modelDropdown.add(option);
        });
    } else if (brand === "Yugo") {
        var models = [
            "45",
            "55",
            "65",
            "Florida",
            "Koral",
            "Skala"
        ];
        models.forEach(function (model) {
            var option = document.createElement("option");
            option.text = model;
            modelDropdown.add(option);
        });
    } else if (brand === "Tesla") {
        var models = [
            "Model S",
            "Model 3",
            "Model X",
            "Model Y",
            "Roadster"
        ];
        models.forEach(function (model) {
            var option = document.createElement("option");
            option.text = model;
            modelDropdown.add(option);
        });
    }else if (brand === "Dacia") {
        var models = [
            "Sandero",
            "Logan",
            "Duster",
            "Dokker",
            "Lodgy"
        ];
        addModelsToDropdown(models, modelDropdown);
    } else if (brand === "Jeep") {
        var models = [
            "Renegade",
            "Compass",
            "Cherokee",
            "Grand Cherokee",
            "Wrangler"
        ];
        addModelsToDropdown(models, modelDropdown);
    } else if (brand === "Ferrari") {
        var models = [
            "812 Superfast",
            "488 GTB",
            "SF90 Stradale",
            "Portofino",
            "Roma"
        ];
        addModelsToDropdown(models, modelDropdown);
    } else if (brand === "Lamborghini") {
        var models = [
            "Huracan",
            "Aventador",
            "Urus"
        ];
        addModelsToDropdown(models, modelDropdown);
    } else if (brand === "Maserati") {
        var models = [
            "Ghibli",
            "Quattroporte",
            "Levante",
            "GranTurismo",
            "GranCabrio"
        ];
        addModelsToDropdown(models, modelDropdown);
    } else if (brand === "Toyota") {
        var models = [
            "Corolla",
            "Camry",
            "Yaris",
            "RAV4",
            "Highlander",
            "Land Cruiser",
            "Prius",
            "Supra"
        ];
        addModelsToDropdown(models, modelDropdown);
    } else if (brand === "Land Rover") {
        var models = [
            "Range Rover",
            "Range Rover Sport",
            "Range Rover Evoque",
            "Range Rover Velar",
            "Discovery",
            "Discovery Sport",
            "Defender"
        ];
        addModelsToDropdown(models, modelDropdown);
    } else if (brand === "Opel") {
        var models = [
            "Corsa",
            "Astra",
            "Insignia",
            "Crossland",
            "Grandland X",
            "Mokka",
            "Combo",
            "Zafira"
        ];
        addModelsToDropdown(models, modelDropdown);
    }
}

function addModelsToDropdown(models, dropdown) {
    models.forEach(function (model) {
        var option = document.createElement("option");
        option.text = model;
        dropdown.add(option);
    });
}

