import pandas as pd
from pandas_datareader import data

# Fetch S&P 500 data from Wikipedia
table = pd.read_html('https://en.wikipedia.org/wiki/List_of_S%26P_500_companies')
df = table[0]


def fetch_sp500_tickers():
    url = 'https://en.wikipedia.org/wiki/List_of_S%26P_500_companies'
    tables = pd.read_html(url)  
    df = tables[0]  
    return df['Symbol'].tolist()  

tickers = fetch_sp500_tickers()

all_stocks = pd.DataFrame()

for ticker in tickers:
    data = yf.download(ticker)
    data['Ticker'] = ticker  
    all_stocks = pd.concat([all_stocks, data])


all_stocks.to_csv('sp500data.csv')



