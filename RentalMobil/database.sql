-- Drop database if it exists and create a new one
DROP DATABASE IF EXISTS db_rental_mobil;
CREATE DATABASE db_rental_mobil;
USE db_rental_mobil;

-- Table for car/vehicle data
CREATE TABLE mobil (
    id INT AUTO_INCREMENT PRIMARY KEY,
    merk VARCHAR(50) NOT NULL,
    model VARCHAR(50) NOT NULL,
    tipe VARCHAR(50) NOT NULL,
    plat_nomor VARCHAR(15) NOT NULL UNIQUE,
    tahun INT NOT NULL,
    harga_sewa_perhari DECIMAL(10,2) NOT NULL,
    status ENUM('Available', 'Rented') NOT NULL DEFAULT 'Available',
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

-- Table for customer data
CREATE TABLE pelanggan (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nama VARCHAR(100) NOT NULL,
    nomor_telepon VARCHAR(20) NOT NULL,
    email VARCHAR(50) NOT NULL,
    alamat TEXT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

-- Table for rental transactions
CREATE TABLE rental (
    id INT AUTO_INCREMENT PRIMARY KEY,
    pelanggan_id INT NOT NULL,
    mobil_id INT NOT NULL,
    tanggal_sewa DATE NOT NULL,
    tanggal_kembali DATE NOT NULL,
    lama_sewa INT NOT NULL,
    harga_perhari DECIMAL(10,2) NOT NULL,
    total_biaya DECIMAL(10,2) NOT NULL,
    metode_pembayaran ENUM('Cash', 'Transfer Bank', 'QRIS', 'Kartu Kredit') NOT NULL,
    status ENUM('Active', 'Completed', 'Cancelled') NOT NULL DEFAULT 'Active',
    catatan TEXT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    FOREIGN KEY (pelanggan_id) REFERENCES pelanggan(id),
    FOREIGN KEY (mobil_id) REFERENCES mobil(id)
);

-- Table for users
CREATE TABLE user (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    nama VARCHAR(100) NOT NULL,
    role ENUM('Admin', 'Staff') NOT NULL,
    status BOOLEAN NOT NULL DEFAULT TRUE,
    last_login TIMESTAMP,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

-- Insert default admin user (password: admin123)
INSERT INTO user (username, password, nama, role) VALUES ('admin', 'admin123', 'Administrator', 'Admin');

-- Insert sample vehicle data
INSERT INTO mobil (merk, model, tipe, plat_nomor, tahun, harga_sewa_perhari) VALUES
('Toyota', 'Avanza', 'MPV', 'B1234CD', 2020, 300000.00),
('Toyota', 'Innova', 'MPV', 'B5678EF', 2021, 450000.00),
('Daihatsu', 'Xenia', 'MPV', 'D9012GH', 2019, 280000.00),
('Honda', 'Brio', 'Hatchback', 'B3456IJ', 2022, 300000.00),
('Honda', 'HR-V', 'SUV', 'B7890KL', 2021, 500000.00),
('Toyota', 'Fortuner', 'SUV', 'B1122MN', 2020, 800000.00);

-- Insert sample customer data
INSERT INTO pelanggan (nama, nomor_telepon, email, alamat) VALUES
('Budi Santoso', '081234567890', 'budi@gmail.com', 'Jl. Merdeka No. 123, Jakarta'),
('Dewi Lestari', '082345678901', 'dewi@gmail.com', 'Jl. Sudirman No. 45, Jakarta'),
('Ahmad Wijaya', '083456789012', 'ahmad@gmail.com', 'Jl. Gatot Subroto No. 67, Jakarta'),
('Siti Rahayu', '084567890123', 'siti@gmail.com', 'Jl. Thamrin No. 89, Jakarta'),
('Rudi Hartono', '085678901234', 'rudi@gmail.com', 'Jl. Kuningan No. 12, Jakarta');

-- Insert sample rental data
INSERT INTO rental (pelanggan_id, mobil_id, tanggal_sewa, tanggal_kembali, lama_sewa, harga_perhari, total_biaya, metode_pembayaran, status)
VALUES
(1, 1, '2025-06-10', '2025-06-12', 2, 300000.00, 600000.00, 'Cash', 'Completed'),
(2, 3, '2025-06-15', '2025-06-20', 5, 280000.00, 1400000.00, 'Transfer Bank', 'Completed'),
(3, 5, '2025-06-25', '2025-06-30', 5, 500000.00, 2500000.00, 'QRIS', 'Completed'),
(4, 2, '2025-07-05', '2025-07-10', 5, 450000.00, 2250000.00, 'Kartu Kredit', 'Completed'),
(5, 6, '2025-07-15', '2025-07-20', 5, 800000.00, 4000000.00, 'Transfer Bank', 'Completed'),
(1, 4, '2025-08-01', '2025-08-05', 4, 300000.00, 1200000.00, 'Cash', 'Completed'),
(2, 1, CURDATE(), DATE_ADD(CURDATE(), INTERVAL 3 DAY), 3, 300000.00, 900000.00, 'QRIS', 'Active');

-- Update mobil status for active rental
UPDATE mobil SET status = 'Rented' WHERE id IN (SELECT mobil_id FROM rental WHERE status = 'Active');
