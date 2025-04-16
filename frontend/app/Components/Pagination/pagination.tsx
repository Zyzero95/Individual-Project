'use client'

import { useRouter, useSearchParams } from "next/navigation"
import { FC } from "react";
import styles from "./pagination.module.css"
import { ArrowLeft, ArrowLeftToLine, ArrowRight, ArrowRightToLine } from "lucide-react";
import { AnimalInterface } from "@/app/Interfaces/animalinterface";

interface PaginationProps {
    hasNextPage: boolean,
    hasPrevPage: boolean,
    query: string,
    filter: string,
    data: AnimalInterface[]
}

// Pagination controls, Display what page you're on and max amount of pages. Will disable button if conditions are met. Followed Youtube guide, Link: https://www.youtube.com/watch?v=SXmni_7B0r4
const Pagination: FC<PaginationProps> = ({
    hasNextPage, hasPrevPage, query, filter, data
}) => {
    const router = useRouter();
    const searchParams = useSearchParams();

    const page = searchParams.get('page') ?? '1';
    const perPage = searchParams.get('per_page') ?? '6';

    return (
        <section className={styles.paginationWrapper}>
            <section className={styles.paginationContainer}>
                <button className={styles.paginationButton} disabled={!hasPrevPage} onClick={() => router.push(`/?page=${1}&per_page=${perPage}${query === "" ? "": `&query=${query}`}${filter === "" ? "" : `&filter=${filter}`}`)}><ArrowLeftToLine aria-label="button-first" size={32}/></button>
                <button className={styles.paginationButton} disabled={!hasPrevPage} onClick={() =>router.push(`/?page=${Number(page) - 1}&per_page=${perPage}${query === "" ? "": `&query=${query}`}${filter === "" ? "" : `&filter=${filter}`}`)}><ArrowLeft aria-label="button-previous" size={32}/></button>
                <p className={styles.paginationParagraph}>{page} / {Math.ceil(data.length / Number(perPage))}</p>
                <button className={styles.paginationButton} disabled={!hasNextPage} onClick={() => router.push(`/?page=${Number(page) + 1}&per_page=${perPage}${query === "" ? "": `&query=${query}`}${filter === "" ? "" : `&filter=${filter}`}`)}><ArrowRight aria-label="button-next" size={32}/></button>
                <button className={styles.paginationButton} disabled={!hasNextPage} onClick={() => router.push(`/?page=${Math.ceil(60 / Number(perPage))}&per_page=${perPage}${query === "" ? "": `&query=${query}`}${filter === "" ? "" : `&filter=${filter}`}`)}><ArrowRightToLine aria-label="button-last" size={32}/></button>
            </section>
        </section>
    )
}

export default Pagination;