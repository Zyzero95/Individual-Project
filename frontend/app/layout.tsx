import type { Metadata } from "next";
import { Roboto } from "next/font/google";
import "./globals.css";
import Header from "./Components/Header/header";
import Footer from "./Components/Footer/footer";
import HeroSection from "./Components/Hero Section/herosection";



const roboto = Roboto({
  variable: "--font-roboto",
  subsets: ["latin"]
});

export const metadata: Metadata = {
  title: "Animal Facts",
  description: "Website created for educational project.",
};

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <html lang="en">
      <body className={`${roboto.variable}`}>
        <Header/>
        <HeroSection/>
        {children}
        <Footer/>
      </body>
    </html>
  );
}
