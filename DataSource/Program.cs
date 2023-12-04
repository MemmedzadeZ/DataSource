using DataSource;

FileDataSource fileDataSource = new FileDataSource("File.json");


DataSourceDecorator encryptedDataSource = new (fileDataSource);
DataSourceDecorator compressedAndEncryptedDataSource = new (encryptedDataSource);

compressedAndEncryptedDataSource.writeData("Salam Step");

compressedAndEncryptedDataSource.readData();