CREATE TABLE Data.MarketHistory (
    Date DATE PRIMARY KEY,
    MarketIndex DECIMAL(10, 2) NOT NULL,
    InflationRate DECIMAL(5, 2) NULL
);
