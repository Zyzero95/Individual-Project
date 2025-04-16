import type { Metadata } from "next";
import { Lexend_Exa, Roboto } from "next/font/google";
import "./globals.css";
import Header from "./Components/Header/header";
import Footer from "./Components/Footer/footer";
import HeroSection from "./Components/Hero Section/herosection";
import { Suspense } from "react";
import Loading from "./Components/Loader/loading";



const roboto = Roboto({
  variable: "--font-roboto",
  subsets: ["latin"]
});

const lexend_exa = Lexend_Exa({
  variable: "--font-lexend-exa",
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
      <body className={`${roboto.variable} ${lexend_exa.variable}`}>
        <Header/>
        <HeroSection/>
        <Suspense fallback={<Loading/>}>
          {children}
        </Suspense>
        <Footer/>
      </body>
    </html>
  );
}
