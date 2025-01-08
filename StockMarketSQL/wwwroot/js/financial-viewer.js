document.addEventListener("DOMContentLoaded", () => {
    const financialTypeSelect = document.getElementById("financialType");
    const loadingIndicator = document.getElementById("loading");
    const financialTable = document.getElementById("financialTable");
    const tableHeader = document.querySelector("#financialTable thead tr");
    const tableBody = document.getElementById("tableBody");

    financialTypeSelect.addEventListener("change", async (event) => {
        const selectedType = event.target.value;

        if (!selectedType) {
            financialTable.style.display = "none";
            return;
        }

        loadingIndicator.style.display = "block";
        financialTable.style.display = "none";

        try {
            const response = await fetch(`/Home/GetFinancialData?financialType=${selectedType}`);
            if (!response.ok) {
                throw new Error(`Failed to fetch data: ${response.statusText}`);
            }
            const data = await response.json();

            console.log("Data fetched:", data); // Debugging log
            populateTable(data);
        } catch (error) {
            console.error("Error fetching financial data:", error);
            alert("An error occurred while fetching the data.");
        } finally {
            loadingIndicator.style.display = "none";
        }
    });

    function populateTable(data) {
        tableHeader.innerHTML = "<th>Column Name</th>";
        tableBody.innerHTML = "";

        if (!data || data.length === 0) {
            alert("No data available for the selected financial type.");
            return;
        }

        const columnNames = Object.keys(data[0]);

        data.forEach((_, index) => {
            const th = document.createElement("th");
            th.textContent = `Row ${index + 1}`;
            th.style.padding = "12px";
            th.style.border = "1px solid #ddd";
            tableHeader.appendChild(th);
        });

        columnNames.forEach((columnName) => {
            const row = document.createElement("tr");

            const nameCell = document.createElement("td");
            nameCell.textContent = columnName;
            nameCell.style.padding = "12px";
            nameCell.style.border = "1px solid #ddd";
            nameCell.style.backgroundColor = "#f9f9f9";
            row.appendChild(nameCell);

            data.forEach((record) => {
                const valueCell = document.createElement("td");
                valueCell.textContent = record[columnName] !== null ? record[columnName] : "-";
                valueCell.style.padding = "12px";
                valueCell.style.border = "1px solid #ddd";
                row.appendChild(valueCell);
            });

            tableBody.appendChild(row);
        });

        financialTable.style.display = "table";
    }
});
