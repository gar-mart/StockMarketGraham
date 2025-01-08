--CREATE TYPE Financial.AnnualEPSTVP AS TABLE (
--    FiscalDateEnding DATE,
--    ReportedEPS DECIMAL(18,6)
--);

CREATE TYPE Financial.QuarterlyEPSTVP AS TABLE (
    FiscalDateEnding DATE,
    ReportedDate DATE,
    ReportedEPS DECIMAL(18,6),
    EstimatedEPS DECIMAL(18,6),
    Surprise DECIMAL(18,6),
    SurprisePercentage DECIMAL(18,6),
    ReportTime NVARCHAR(50)
);
